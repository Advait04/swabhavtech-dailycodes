interface ICustomer
{
    id:number;
    firstName:string;
    lastName:string;
    location ? :string;

}
printDetails([{firstName:'Rohit',id:101,lastName:'Sharma',location:'Mumbai'},{firstName:'Virat',id:102,lastName:'Kohli',location:'Banglore'}])
function printDetails(customers:Array<ICustomer>)
{
    for (let c of customers)
     {
        console.log(c)
     }

}