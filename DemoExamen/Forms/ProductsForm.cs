using DemoExamen.Forms.Base;
using DemoExamen.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExamen.Forms
{
    public partial class ProductsForm : BaseForm
    {
        const string ORDER_COST_ASC = "По возрастанию цены";
        const string ORDER_COST_DESC = "По убыванию цены";
        public ProductsForm()
        {
            InitializeComponent();
            LoadProductList();
            costBox.Items.Add(ORDER_COST_ASC);
            costBox.Items.Add(ORDER_COST_DESC);
        }

        private void LoadProductList()
        {
            var search = searchBox.Text;
            var orderCost = costBox.Text;
            flowLayoutPanel1.Controls.Clear();
            using (TradeEntities context = new TradeEntities())
            {
                List<Product> products = new List<Product>();
                if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(orderCost))
                {
                    products = getWithOrderByAndSearch(search, orderCost);
                } else if (!string.IsNullOrEmpty(search))
                {
                    products = getBySearch(search);
                } else if (!string.IsNullOrEmpty(orderCost))
                {
                    products = getWithOrderBy(orderCost);
                } else
                {
                    products = getProducts();
                }

                products.ForEach(p =>
                {
                    var control = new ProductControl(p);
                    flowLayoutPanel1.Controls.Add(control);
                });
            }
        }

        private List<Product> getProducts()
        {
            using (TradeEntities context = new TradeEntities())
            {
                return context.Product.ToList();
            }
        }


        private List<Product> getBySearch(string search)
        {
            using (TradeEntities context = new TradeEntities())
            {
                return context.Product.Where(p => p.ProductName.Contains(search)).ToList();
            }
        }

        private List<Product> getWithOrderBy(string orderParam)
        {
            using (TradeEntities context = new TradeEntities())
            {
                switch (orderParam)
                {
                    case ORDER_COST_ASC:
                        return context.Product.OrderBy(p => p.ProductCost).ToList();
                    case ORDER_COST_DESC:
                        return context.Product.OrderByDescending(p => p.ProductCost).ToList();
                }
            }
            return getProducts();
        }

        private List<Product> getWithOrderByAndSearch(string search, string orderParam)
        {
            using (TradeEntities context = new TradeEntities())
            {
                switch (orderParam)
                {
                    case ORDER_COST_ASC:
                        return context.Product.Where(p => p.ProductName.Contains(search)).OrderBy(p => p.ProductCost).ToList();
                    case ORDER_COST_DESC:
                        return context.Product.Where(p => p.ProductName.Contains(search)).OrderByDescending(p => p.ProductCost).ToList();
                }
            }
            return getProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void costBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void manufacturureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductList();
        }
    }
}
