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
        private Store s;
        protected void Page_PreInit(object sender, EventArgs e)
        {
            s = new Store();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.s.LoadFromDataBase();
            int i = 0;
            string rowID;
            if (s.books != null) {
                /* Agregar filas a la tabla*/
                foreach (Book x in s.books)
                {
                    /* Crear filas en html */
                    TableRow tr = new TableRow();
                    rowID = "Row" + i; // cada fila tiene un id que es su indice basicamente mas el nombre "Row"
                    tr.ID = rowID;

                    /* Crear celdas por fila en html*/
                    TableCell[] tc = new TableCell[5];

                    /* Inicializar celdas */
                    for (int j = 0; j < 5; j++)
                    {
                        tc[j] = new TableCell();
                        tc[j].CssClass = "cellBorder";
                    }

                    /* Añadir valores a las celdas de la tabla */
                    tc[0].Text = x.title;
                    tc[1].Text = x.type.author;
                    tc[2].Text = x.type.type;
                    tc[3].Text = x.type.other;
                    tc[4].Text = x.price.ToString();


                    /* Añadir celdas a la fila */
                    for (int j = 0; j < 5; j++)
                    {
                        tr.Cells.Add(tc[j]);
                    }

                    /* Esta es la parte que agrega la fila creada a la tabla*/
                    TableBooks.Rows.Add(tr);
                    i++;
                }
            }
        }

        /**
         * Navegacion a formmulario para crear registros
         */
        protected void NuevoLibro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\NuevoLibro.aspx");
        }

    }
}