// See https://aka.ms/new-console-template for more information

EcommerceDbContext db = new EcommerceDbContext();
Product product1 = new Product() { Name = "product1", Description = "descrizione", Price = 10.99 };
Product product2 = new Product() { Name = "product2", Description = "descrizione", Price = 11.99 };
Product product3 = new Product() { Name = "product3", Description = "descrizione", Price = 12.99 };
Product product4 = new Product() { Name = "product4", Description = "descrizione", Price = 13.99 };
Product product5 = new Product() { Name = "product5", Description = "descrizione", Price = 14.99 };
Product product6 = new Product() { Name = "product6", Description = "descrizione", Price = 15.99 };
Product product7 = new Product() { Name = "product7", Description = "descrizione", Price = 16.99 };
Product product8 = new Product() { Name = "product8", Description = "descrizione", Price = 17.99 };
Product product9 = new Product() { Name = "product9", Description = "descrizione", Price = 18.99 };
Product product10 = new Product() { Name = "product10", Description = "descrizione", Price = 19.99 };

if (db.Products.Count() < 10)
{
    db.Products.Add(product1);
    db.Products.Add(product2);
    db.Products.Add(product3);
    db.Products.Add(product4);
    db.Products.Add(product5);
    db.Products.Add(product6);
    db.Products.Add(product7);
    db.Products.Add(product8);
    db.Products.Add(product9);
    db.Products.Add(product10);
}

db.SaveChanges();

