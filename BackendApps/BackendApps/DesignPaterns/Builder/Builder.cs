using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Builder
{
    

   
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
    }
    public abstract class ProductBuilder
    {
        public abstract void GetProductDate();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();
    }
     class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel _model = new ProductViewModel();
        public override void GetProductDate()
        {
            _model.Name = "kola";
            _model.Description = "kola";
            _model.UnitPrice = 100;
        }

        public override void ApplyDiscount()
        {
            _model.DiscountedPrice = _model.UnitPrice * (decimal)0.10;
        }
        public override ProductViewModel GetModel()
        {
            return _model;
        }
    }
    class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel _model = new ProductViewModel();
        public override void GetProductDate()
        {
            _model.Name = "kola";
            _model.Description = "kola";
            _model.UnitPrice = 100;
        }

        public override void ApplyDiscount()
        {
            _model.DiscountedPrice = _model.UnitPrice * (decimal)0.90;
        }
        public override ProductViewModel GetModel()
        {
            return _model;
        }
    }
    public  class  ProductDiractor
    {
        public void GenerateProduct(ProductBuilder Builder)
        {
            Builder.GetProductDate();
            Builder.ApplyDiscount();
        }
    }
        






    }
