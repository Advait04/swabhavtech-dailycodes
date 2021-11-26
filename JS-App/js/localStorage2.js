function funCall()
{
    var s1={name:"Advait",cgpa:8.5,location:"mumbai"}
            console.log(s1.name);
            console.log(s1["name"]) //property syntex
            console.log(s1['cgpa']);
            console.log(s1["location"]);

            localStorage["aurionpro.student"]=s1  //[object]
            console.log(localStorage["aurionpro.student"]);
            localStorage["aurionpro.student"] = JSON.stringify(s1);
            console.log(localStorage["aurionpro.student"]);
           
            console.log(s1);
    var student=[{
        name:"Advait",
        cgpa:7.5,
        location:"Mumbai"
        },
        {
         name:"Aditya",
         cgpa:8.5,
         location:"Jaipur"
        },   
        {
        name:"Rohit",
        cgpa:6.8,
        location:"Mumbai"
        },
        {
        name:"Virat",
        cgpa:6.9,
        location:"Banglore"
        },
        {
        name:"KL",
        cgpa:9.4,
        location:"Banglore"
        }];
    var html="<table border='1|1'>"

            localStorage["aurionpro.student"] = JSON.stringify(student);
            console.log(localStorage["aurionpro.student"]);
            console.log("Student Residing In Mumbai");
            student.forEach(element =>{
                if(element.location == "Mumbai")
                {
                    console.log("name:"+element.name);
                }

            });

            console.log("Students With With CGPA Greater Than 7");
            student.forEach(element => {
                if(element.cgpa > 7){
                    console.log("name:"+element.name);
                    console.log("cgpa:"+element.cgpa);
                }
            });

            console.log("Students Having Long Name:");
            student.forEach(element => {
                if(element.name.length > 7)
                {
                    console.log("name:"+element.name);
                }
            });


    setTimeout(() => {
            html+='<thread>'
            html+='<tr>';
            html+='<td>'+'Name'+'</td>';
            html+='<td>'+'CGPA'+'</td>';
            html+='<td>'+'Location'+'</td>';
            html+='</tr>';
            html+='</thread>'

        for(var i=0;i<student.length;i++)
        {
            html+='<tr>';
            html+='<td>'+student[i].name+'</td>';
            html+='<td>'+student[i].cgpa+'</td>';
            html+='<td>'+student[i].location+'</td>';
            html+='</tr>';
        }

        document.getElementById("table").innerHTML=html;
    }, 500);

}

funCall();