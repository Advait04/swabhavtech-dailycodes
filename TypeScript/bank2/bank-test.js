"use strict";
// import Bank,{Account,Customer} from './bank-module'
Object.defineProperty(exports, "__esModule", { value: true });
// let b = new Bank("HDFC","Mumbai")
var b = require("./bank-module");
var a = new b.Account(100);
var c = new b.Customer(1001, "Virat");
