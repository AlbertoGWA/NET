using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_CONSUME_SERVICE
{

    public partial class _Default : Page
    {
        protected WFC_NORTHWND.Service1Client client = new WFC_NORTHWND.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            //insertCategory();
        }

      
        protected void validation()
        {
            //pbxPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            //txtID.Enabled = false;

        }

        protected void ButtonInsert_Click(object sender, EventArgs e)
        {
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //pbxPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //client.insertCategory(new NORTHWND.Models.categoriaModel
            //{
            //    CategoryName = txtName.Text,
            //    Description = rtxtDescription.Text,
            //    Picture = ms.GetBuffer()
            //});
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //pbxPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //categoriaManager.update(new NORTHWND.Models.categoriaModel
            //{
            //    CategoryID = Convert.ToInt32(txtID.Text),
            //    CategoryName = txtName.Text,
            //    Description = rtxtDescription.Text,
            //    Picture = ms.GetBuffer()
            //});
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            //categoriaManager.delete(new NORTHWND.Models.categoriaModel
            //{
            //    CategoryID = Convert.ToInt32(txtID.Text)
            //});
        }

        protected void SearchName_Click(object sender, EventArgs e)
        {
            //HELP.FRM_HELP help = new HELP.FRM_HELP();
            //help.genericGridview.DataSource = categoriaManager.searchName(new NORTHWND.Models.categoriaModel
            //{
            //    CategoryName = txtName.Text
            //});
            //help.ShowDialog();
            //if (help.id != 0)
            //{
            //    setCategory(categoriaManager.select(new NORTHWND.Models.categoriaModel
            //    {
            //        CategoryID = help.id
            //    }));
            //}
        }

        protected void SearchDescription_Click(object sender, EventArgs e)
        {
            //HELP.FRM_HELP help = new HELP.FRM_HELP();
            //help.genericGridview.DataSource = categoriaManager.searchDescription(new NORTHWND.Models.categoriaModel
            //{
            //    Description = rtxtDescription.Text
            //});
            //help.ShowDialog();
            //if (help.id != 0)
            //{
            //    setCategory(categoriaManager.select(new NORTHWND.Models.categoriaModel
            //    {
            //        CategoryID = help.id
            //    }));
            //}
        }

        protected void ButtonLoadPhoto_Click(object sender, EventArgs e)
        {
            //OpenFileDialog getImg = new OpenFileDialog();
            //getImg.InitialDirectory = "C:\\";
            //getImg.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            //if (getImg.ShowDialog() == DialogResult.OK)
            //{
            //    pbxPicture.ImageLocation = getImg.FileName;
            //}
        }
        protected void setCategory(NORTHWND.Models.categoriaModel categoriaModel)
        {
            //txtID.Text = categoriaModel.CategoryID.ToString();
            //txtName.Text = categoriaModel.CategoryName;
            //rtxtDescription.Text = categoriaModel.Description;
            //pbxPicture.Image = Image.FromStream(new System.IO.MemoryStream(categoriaModel.Picture));
        }
    }
}