"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var bank_module_1 = require("./bank-module");
var a = new bank_module_1.Account(1001);
var b = new bank_module_1.Bank("HDFC", "Mumbai");
var c = new bank_module_1.Customer(1, "Rohit");
console.log(a, b, c);
console.log({ a: a, b: b, c: c });
