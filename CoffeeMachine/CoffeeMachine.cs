using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private List<CoffeeType> coffeesSold;
    private int coins;

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }

    public List<CoffeeType> CoffeesSold => this.coffeesSold;

    public void BuyCoffee(string size, string type)
    {
        var coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        var coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);

        if (this.coins >= (int)coffeePrice)
        {
            this.coffeesSold.Add(coffeeType);
            this.coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        Coin rem = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int)rem;
    }
}