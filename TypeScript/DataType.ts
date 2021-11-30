function sayHello(name:string) : string 
{
    return `
            Hello Mr ${name}
    `
}

console.log(sayHello("AurionPro"))

let userName:string="Advait";
let cgpa:number = 6.32
let isActiveUser=true
let displayText= `
Name :${userName}
cgpa :${cgpa}
userIsActive: ${isActiveUser}
`
console.log(displayText);