using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem : EntityBase
	{
		public OrderItem()
		{

		}

		public OrderItem(int orderItemId)
		{
			OrderItemId = orderItemId;
		}

		public int OrderItemId { get; private set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal? PurchasePrice { get; set; }

		public OrderItem Retreive(int orderItemId)
		{
			return new OrderItem();
		}

		public List<OrderItem> Retreive()
		{
			return new List<OrderItem>();
		}

		public bool Save(OrderItem orderItem)
		{
			var success = true;

			if (orderItem.HasChanges)
			{
				if (orderItem.IsValid)
				{
					if (orderItem.IsNew)
					{

					}
					else
					{

					}
				}
				else
				{
					success = false;
				}
			}

			return success;
		}

		public override bool Validate()
		{
			var isValid = true;

			if (Quantity <= 0) isValid = false;
			if (ProductId <= 0) isValid = false;
			if (PurchasePrice == null) isValid = false;

			return isValid;
		}
	}
}
