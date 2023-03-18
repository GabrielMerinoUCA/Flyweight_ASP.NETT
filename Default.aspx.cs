using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Flyweight_Pattern.Buisness;

namespace Flyweight_Pattern
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Store.books != null)
            {
                int i = 0;
                string rowID;
                foreach (Book x in Store.books)
                {
                    TableRow tr = new TableRow();
                    rowID = "Row" + i;
                    tr.ID = rowID;

                    TableCell[] tc = new TableCell[5];

                    for (int j = 0; j < 5; j++)
                    {
                        tc[j] = new TableCell();
                        tc[j].CssClass = "cellBorder";
                    }

                    tc[0].Text = x.title;
                    tc[1].Text = x.type.author;
                    tc[2].Text = x.type.type;
                    tc[3].Text = x.type.other;
                    tc[4].Text = x.price.ToString();


                    for (int j = 0; j < 5; j++)
                    {
                        tr.Cells.Add(tc[j]);
                    }

                    TableBooks.Rows.Add(tr);
                    i++;
                }

            }
        }

        protected void NuevoLibro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\NuevoLibro.aspx");
        }

    }
}