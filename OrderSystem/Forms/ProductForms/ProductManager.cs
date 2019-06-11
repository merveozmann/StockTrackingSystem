using OrderStockSystem.DatabaseTables;
using System.Linq;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.ProductForms
{
    public class ProductManager
    {
        #region members
        private AddProductForm addProductForm;
        private ListProductForm listProductForm;
        private OrderDbContext context;
        #endregion members

        #region constructor
        public ProductManager()
        {
            addProductForm = new AddProductForm();
            listProductForm = new ListProductForm();
            context = new OrderDbContext();
        }
        #endregion  constructor

        #region methods

        #region addForm
        public void AddShow()
        {
            addProductForm.Show();
            addProductEvents();
        }

        private void addProductEvents()
        {
            addProductForm.AddProduct += addProduct;
            addProductForm.UpdateProduct += updateProduct;
            addProductForm.DeleteProduct += deleteProduct;
            addProductForm.FormClosed += formClosed;
            addProductForm.List += list;
        }

        private void addProduct(int pProductKode, string pProductName, int pAmount, string pMemory, string pUsegeArea, string pDiskCapacity, string pSpeed, int pWarrantay, string pSize)
        {
            Product product = new Product();
            product.Product_Kode = pProductKode;
            product.Product_Name = pProductName;
            product.Amount = pAmount;
            product.Memory = pMemory;
            product.Usage_Area = pUsegeArea;
            product.Disk_Capacity = pDiskCapacity;
            product.Rotation_Speed = pSpeed;
            product.Warranty = pWarrantay;
            product.Size = pSize;
            context.Product.Add(product);
            context.SaveChanges();
            MessageBox.Show("Ürün başarılıyla oluşturuldu");

        }

        private void updateProduct(int pProductId, int pProductKode, string pProductName, int pAmount, string pMemory, string pUsegeArea, string pDiskCapacity, string pSpeed, int pWarrantay, string pSize)
        {
            var update = context.Product.Where(m => m.Product_Id == pProductId).FirstOrDefault();
            Product product = new Product();
            product.Product_Kode = pProductKode;
            product.Product_Name = pProductName;
            product.Amount = pAmount;
            product.Memory = pMemory;
            product.Usage_Area = pUsegeArea;
            product.Disk_Capacity = pDiskCapacity;
            product.Rotation_Speed = pSpeed;
            product.Warranty = pWarrantay;
            product.Size = pSize;
            context.SaveChanges();
            MessageBox.Show("Ürün başarılıyla güncellendi.");
        }

        private void deleteProduct(int pProductId)
        {
            var delete = context.Product.Where(m => m.Product_Id == pProductId).FirstOrDefault();
            context.Product.Remove(delete);
            context.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir.");
        }

        private void list()
        {
            addProductForm.ProductDatasource = context.Product.ToList();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        #endregion addForm

        #region listForm

        public void ListShow()
        {
            listProductForm.Show();
            listProductEvents();
        }

        private void listProductEvents()
        {
            listProductForm.Filter += filter;
            listProductForm.List += listProductForm_list;
            listProductForm.FormClosed += listProductForm_formClosed;
        }

        private void filter(string pProductName)
        {
            var query = from c in context.Product
                        where c.Product_Name == pProductName
                        select c;
            var kode = query.FirstOrDefault<Product>();
            var id = context.Product.Where(m => m.Product_Id == kode.Product_Id).FirstOrDefault();
            listProductForm.ProductDatasource = query.ToList();
        }

        private void listProductForm_list()
        {
            listProductForm.ProductDatasource = context.Product.ToList();
        }

        private void listProductForm_formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }


        #endregion listForm

        #endregion methods

    }
}
