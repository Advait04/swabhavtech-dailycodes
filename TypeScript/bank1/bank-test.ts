import { Account,Bank,Customer } from "./bank-module";
let a = new Account(1001)
let b = new Bank("HDFC","Mumbai")
let c  =new  Customer(1,"Rohit")

console.log(a,b,c)
console.log({a,b,c})