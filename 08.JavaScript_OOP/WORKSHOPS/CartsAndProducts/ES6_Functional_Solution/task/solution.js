function solve() {
    function getProduct(productType, name, price) {
        return {
            productType: productType,
            name: name,
            price: price
        };
    }

    function getShoppingCart() {
        let products = [];

        function add(product) {
            if (!product.hasOwnProperty('productType') ||
                !product.hasOwnProperty('name') ||
                !product.hasOwnProperty('price')) {
                throw "Invalid product passed to add.";
            }
            products.push(product);
            return this;
        };

        function remove(product) {
            let productIndex = products.findIndex(p => (p.name === product.name));
            if (productIndex <= -1) {
                throw "Cannot remove from an empty cart";
            }
            products.splice(productIndex, 1);
            return this;
        };

        function showCost() {
            let sum = 0;
            if (products) {
                products.forEach(p => {
                    sum += p.price;
                });
            }
            return sum;
        };

        function showProductTypes() {
            let productTypes = [];
            if (products) {
                products.forEach(p => {
                    if (!productTypes.includes(p.productType)) {
                        productTypes.push(p.productType);
                    }
                });
            }
            productTypes.sort();
            return productTypes;
        };

        function getInfo() {
            let infoContainer = {};
            infoContainer.totalPrice = showCost();
            infoContainer.products = getProducts();
            return infoContainer;
        };

        function getProducts() {
            let productInfo = [];
            if (products) {
                products.forEach(p => getProductInfo(p));
            }
            return productInfo;

            function getProductInfo(product) {
                if (productInfo.length === 0 ||
                    !productInfo.some(p => (p.name === product.name))) {
                    let infoContainer = {};
                    infoContainer.name = product.name;
                    infoContainer.totalPrice = product.price;
                    infoContainer.quantity = 1;
                    productInfo.push(infoContainer);
                } else {
                    let productIndex = productInfo.findIndex(p => (p.name === product.name));
                    productInfo[productIndex].totalPrice += product.price;
                    productInfo[productIndex].quantity += 1;
                }
            };
        };

        return {
            products: products,
            add: add,
            remove: remove,
            showCost: showCost,
            showProductTypes: showProductTypes,
            getInfo: getInfo
        };
    }

    return {
        getProduct: getProduct,
        getShoppingCart: getShoppingCart
    };
}

module.exports = solve();
