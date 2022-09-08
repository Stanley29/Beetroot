namespace Lesson13_Abstract;

public class Product
{
    TypeOfProduct type;
    int quantity;
    double price;

    public Product(TypeOfProduct type, int quantity, double price)
    {
        this.price = price;
        this.quantity = quantity;
        this.type = type;
    }
}