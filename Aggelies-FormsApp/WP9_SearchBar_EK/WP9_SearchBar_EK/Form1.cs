using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP9_SearchBar_EK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ADS' table. You can move, or remove it, as needed.
            this.aDSTableAdapter.Fill(this.database1DataSet.ADS);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var query = searchTB.Text.Trim();

            var results = search(query);
            AdsGV.DataSource = results;

        }
        Directory createIndex(DataTable table)
        {
            var directory = new RAMDirectory();
            using (Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30))
            using (var writer = new IndexWriter(directory, analyzer, new IndexWriter.MaxFieldLength(1000)))
            {
                foreach (DataRow row in table.Rows)
                {
                    var document = new Document();
                    document.Add(new Field("AD_TITLE", row["AD_TITLE"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
                    document.Add(new Field("DESCRIPTION", row["DESCRIPTION"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
                    document.Add(new Field("PRICE", row["PRICE"].ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
                    document.Add(new Field("AD_ID", row["AD_ID"].ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
                    document.Add(new Field("INSERT_DATE", row["INSERT_DATE"].ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));


                    document.Add(new Field("FullText", string.Format("{0} {1}",row["AD_TITLE"], row["DESCRIPTION"]), Field.Store.YES, Field.Index.ANALYZED));

                    writer.AddDocument(document);
                }
                writer.Optimize();
                writer.Flush(true, true, true);
            }
            return directory;
        }

        DataTable search(string textSearch)
        {
            var table = this.database1DataSet.ADS.Clone();

            var Index = createIndex(this.database1DataSet.ADS);

            using (var reader = IndexReader.Open(Index, true))
            using (var searcher = new IndexSearcher(reader))
            {
                using (Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30))
                {
                    var queryParser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "FullText", analyzer);
                    queryParser.AllowLeadingWildcard = true;

                    var query = queryParser.Parse("*" + searchTB.Text + "*");

                    var collector = TopScoreDocCollector.Create(1000, true);

                    searcher.Search(query, collector);

                    var matches = collector.TopDocs().ScoreDocs;

                    foreach (var item in matches)
                    {
                        var id = item.Doc;
                        var doc = searcher.Doc(id);

                        var row = table.NewRow();
                        row["AD_ID"] = doc.GetField("AD_ID").StringValue;
                        row["AD_TITLE"] = doc.GetField("AD_TITLE").StringValue;
                        row["DESCRIPTION"] = doc.GetField("DESCRIPTION").StringValue;
                        row["PRICE"] = doc.GetField("PRICE").StringValue;
                        row["INSERT_DATE"] = doc.GetField("INSERT_DATE").StringValue;
                        table.Rows.Add(row);
                    }
                }
            }
            return table;
        }


    }
}
