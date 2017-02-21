/* globals module */

"use strict";

function solve() {
    class Product {
        constructor(productType, name, price) {
            this.productType = productType;
            this.name = name;
            this.price = price;
        }

        set productType(value) {
            this._productType = value;
        }
        get productType() {
            return this._productType;
        }

        set name(value) {
            this._name = value;
        }
        get name() {
            return this._name;
        }

        set price(value) {
            this._price = value;
        }
        get price() {
            return this._price;
        }
    }

    class ShoppingCart {
        constructor() {
            this._products = [];
        }

        get products() {
            return this._products;
        }

        add(product) {
            if(!product.hasOwnProperty('_productType') ||
               !product.hasOwnProperty('_name') ||
               !product.hasOwnProperty('_price')) {
                throw new Error("Invalid product passed to add");
            }
            this._products.push(product);
            return this;
        }

        remove(product) {
            let productIndex = this._products.findIndex(p => p.name === product.name);
            if (productIndex <= -1) {
                throw new Error("Cannot remove from an empty cart");
            }
            this._products.splice(productIndex, 1);
            return this;
        }

        showProductTypes() {
            let productTypesHashset = [];
            this._products.forEach(p => {
                if (!productTypesHashset.includes(p.productType)) {
                    productTypesHashset.push(p.productType);
                }
            });
            productTypesHashset.sort();
            return productTypesHashset;
        }

        getInfo() {
            let infoContainer = {};
            infoContainer.totalPrice = this.showCost();
            infoContainer.products = this.showProducts();
            return infoContainer;
        }

        showCost() {
            let totalCost = this._products.reduce((a, b) => a + b.price, 0);
            return totalCost;
        }

        showProducts() {
            let totalProducts = [];

            this._products.forEach(product => {
                if (totalProducts.some(p => p.name === product.name)){
                    let productIndex = totalProducts.findIndex(p => (p.name === product.name));
                    totalProducts[productIndex].totalPrice += product.price;
                    totalProducts[productIndex].quantity += 1;
                } else {
                    let productTypeObject = {};
                    productTypeObject.name = product.name;
                    productTypeObject.totalPrice = product.price;
                    productTypeObject.quantity = 1;
                    totalProducts.push(productTypeObject);
                }
            });

            return totalProducts;
        }
    }

    return {
        Product,
        ShoppingCart
    };
}

module.exports = solve;


// MY TESTS
// let {
//     ShoppingCart,
//     Product
// } = solve();

// let cart = new ShoppingCart();

// let pr1 = new Product("Sweets", "Shokolad Milka", 2);
// cart.add(pr1);
// let pr2 = new Product("Groceries", "Salad", 0.5);
// cart.add(pr2);
// cart.add(pr2);

// console.log(cart.getInfo());

// cart.remove({name:"Salad", productType: "Groceries", price: 0.5});

// console.log(cart.getInfo());
