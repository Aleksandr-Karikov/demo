using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExamen.UI
{
    public partial class ProductControl : UserControl
    {
        public ProductControl(Product product)
        {
            InitializeComponent();
            Initial(product);
        }

        private void Initial(Product product)
        {
            productCost.Text = product.ProductCost.ToString();
            productCount.Text = product.ProductQuantityInStock + product.ProductUnit;
            productDescription.Text = product.ProductDescription;
            productManufacture.Text = product.ProductManufacturer;
            productName.Text = product.ProductName;
            if (product.ProductQuantityInStock == 0)
            {
                this.BackColor = Color.Gray;
            }
            if (product.ProductPhoto != null)
            {
                MemoryStream ms = new MemoryStream(product.ProductPhoto);
                ms.Position = 0;
                productPhoto.Image = Image.FromStream(ms);
            }
        }
    }
}
