function moneyToBuyFruit(fruit, weight, pricePerKg){
    let weightInKg = (weight / 1000);
    let totalPrice = weightInKg * pricePerKg;

    console.log(`I need $${totalPrice.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`)
}

moneyToBuyFruit('orange', 2500, 1.80);