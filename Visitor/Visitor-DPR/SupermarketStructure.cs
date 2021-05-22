using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class SupermarketStructure
    {
        //properties
        public List<IProductElement> ProductElements;

        //Constructor
        public SupermarketStructure()
        {
            this.ProductElements = new List<IProductElement>();
        }
        //Methods
        public double Accept(IShoppingCartVisitor visitor)
        {
            double FinlaPrice = 0;
            foreach (var element in ProductElements)
            {
                FinlaPrice += element.Accept(visitor);
            }
            return FinlaPrice;
        }

        public void DeleteElement(IProductElement elementToRemove)
        {
            ProductElements.Remove(elementToRemove);
        }

        public void AddElement(IProductElement ElementToAdd)
        {

            ProductElements.Add(ElementToAdd);

        }

        public void AddListOfElemets(List<IProductElement> newList)
        {
            foreach (var item in newList)
            {
                ProductElements.Add(item);
            }
        }

        public void NewClient()
        {
            ProductElements.Clear();
        }

    }
}
