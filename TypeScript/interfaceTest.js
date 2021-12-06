printDetails([{ firstName: 'Rohit', id: 101, lastName: 'Sharma', location: 'Mumbai' }, { firstName: 'Virat', id: 102, lastName: 'Kohli', location: 'Banglore' }]);
function printDetails(customers) {
    for (var _i = 0, customers_1 = customers; _i < customers_1.length; _i++) {
        var c = customers_1[_i];
        console.log(c);
    }
}
