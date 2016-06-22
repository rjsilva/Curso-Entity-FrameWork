using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Net_Entity_FrameWork
{
    public partial class formulario : System.Web.UI.Page
    {

        protected void frmView_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            gvtimes.DataBind();
        }

        protected void gvtimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmView.ChangeMode(FormViewMode.Edit);
        }

        protected void frmView_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            gvtimes.DataBind();
        }

       
    }
}