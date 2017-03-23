function solve(args) {
    let objects = [];

    for(let i = 0; i < args.length; i++) {
        let result = JSON.parse(args[i]);
        objects.push(result);
    }

    for(let i = 0; i < objects.length; i++)
    {
        console.log(`Name: ${objects[i].name}`);
        console.log(`Age: ${objects[i].age}`);
        console.log(`Date: ${objects[i].date}`);
    }
}

solve([{"name":"Gosho","age":10,"date":"19/06/2005"}, {"name":"Tosho","age":11,"date":"04/04/2005"}]);
