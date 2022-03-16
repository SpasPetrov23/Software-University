class CarDealership {
    constructor(name) {
        this.name = name;
        this.availableCars = [];
        this.soldCars = [];
        this.totalIncome = 0;
    }

    addCar(model, horsepower, price, mileage) {
        if (!model || horsepower < 0 || price < 0 || mileage < 0) {
            throw new Error('Invalid input!')
        }

        let car = {
            model,
            horsepower,
            price,
            mileage
        };

        this.availableCars.push(car)

        return `New car added: ${car.model} - ${car.horsepower} HP - ${car.mileage.toFixed(2)} km - ${car.price.toFixed(2)}$`
    }

    sellCar(model, desiredMileage) {
        let carToSell = this.availableCars.find(x => x.model == model);

        if (!carToSell) {
            throw new Error(`${model} was not found!`)
        }

        if (carToSell.mileage <= desiredMileage) {
            //Nothing
        } else if ((carToSell.mileage - desiredMileage) <= 40000) {
            carToSell.price *= 0.95;
        } else if ((carToSell.mileage - desiredMileage) > 40000) {
            carToSell.price *= 0.90;
        }

        this.availableCars = this.availableCars.filter(x => x.model != carToSell.model);

        let soldCar = {
            model: carToSell.model,
            horsepower: carToSell.horsepower,
            soldPrice: carToSell.price.toFixed(2)
        };

        this.soldCars.push(soldCar);
        this.totalIncome += Number(soldCar.soldPrice);

        return `${soldCar.model} was sold for ${soldCar.soldPrice}$`;
    }

    currentCar() {
        if (this.availableCars.length <= 0) {
            return 'There are no available cars';
        }

        let result = [];
        result.push(`-Available cars:`);

        this.availableCars
            .forEach(x => {
                result.push(`---${x.model} - ${x.horsepower} HP - ${x.mileage.toFixed(2)} km - ${x.price.toFixed(2)}$`);
            })

        return result.join('\n');
    }

    salesReport(criteria) {
        if (criteria != 'horsepower' && criteria != 'model') {
            throw new Error('Invalid criteria!');
        }

        let result = [];
        result.push(`-${this.name} has a total income of ${this.totalIncome.toFixed(2)}$`)
        result.push(`-${this.soldCars.length} cars sold:`);
        if (criteria == 'horsepower') {
            this.soldCars
                .sort((a, b) => b.horsepower - a.horsepower)
                .forEach(x => {
                    result.push(`---${x.model} - ${x.horsepower} HP - ${x.soldPrice}$`);
                })

        } else if (criteria == 'model') {
            this.soldCars
                .sort((a, b) => {
                    return (a.model).localeCompare(b.model)
                })
                .forEach(x => {
                    result.push(`---${x.model} - ${x.horsepower} HP - ${x.soldPrice}$`);
                })
        }
        return result.join('\n');
    }
}

let dealership = new CarDealership('SoftAuto');
dealership.addCar('Toyota Corolla', 100, 3500, 190000);
dealership.addCar('Mercedes C63', 300, 29000, 187000);
dealership.addCar('Audi A3', 120, 4900, 240000);
dealership.sellCar('Toyota Corolla', 230000);
dealership.sellCar('Mercedes C63', 110000);
console.log(dealership.salesReport('model'));