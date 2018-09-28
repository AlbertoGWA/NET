using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VIEWFORM
{
    public partial class ViewNORTHWND : Form
    {
        private NORTHWND.Managers.categoriaManager categoriaManager = new NORTHWND.Managers.categoriaManager();
        public ViewNORTHWND()
        {
            InitializeComponent();
            validation();
        }

        private void validation() {
            pbxPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            txtID.Enabled = false;
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbxPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            categoriaManager.insert(new NORTHWND.Models.categoriaModel {
                CategoryName = txtName.Text,
                Description = rtxtDescription.Text,
                Picture = ms.GetBuffer()
            });
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbxPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            categoriaManager.update(new NORTHWND.Models.categoriaModel
            {
                CategoryID = Convert.ToInt32(txtID.Text),
                CategoryName = txtName.Text,
                Description = rtxtDescription.Text,
                Picture = ms.GetBuffer()
            });
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            categoriaManager.delete(new NORTHWND.Models.categoriaModel
            {
                CategoryID = Convert.ToInt32(txtID.Text)
            });
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            HELP.FRM_HELP help = new HELP.FRM_HELP();
            help.genericGridview.DataSource = categoriaManager.searchName(new NORTHWND.Models.categoriaModel
            {
                CategoryName = txtName.Text
            });
            help.ShowDialog();
            if (help.id != 0) {
                setCategory(categoriaManager.select(new NORTHWND.Models.categoriaModel {
                    CategoryID = help.id
                }));
            }
        }

        private void SearchDescription_Click(object sender, EventArgs e)
        {
            HELP.FRM_HELP help = new HELP.FRM_HELP();
            help.genericGridview.DataSource = categoriaManager.searchDescription(new NORTHWND.Models.categoriaModel
            {
                Description = rtxtDescription.Text
            });
            help.ShowDialog();
            if (help.id != 0)
            {
                setCategory(categoriaManager.select(new NORTHWND.Models.categoriaModel
                {
                    CategoryID = help.id
                }));
            }
        }

        private void ButtonLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImg = new OpenFileDialog();
            getImg.InitialDirectory = "C:\\";
            getImg.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            if (getImg.ShowDialog() == DialogResult.OK)
            {
                pbxPicture.ImageLocation = getImg.FileName;
            }
        }
        private void setCategory(NORTHWND.Models.categoriaModel categoriaModel) {
            txtID.Text = categoriaModel.CategoryID.ToString();
            txtName.Text = categoriaModel.CategoryName;
            rtxtDescription.Text = categoriaModel.Description;
            pbxPicture.Image = Image.FromStream(new System.IO.MemoryStream(categoriaModel.Picture));
        }
    }
}
