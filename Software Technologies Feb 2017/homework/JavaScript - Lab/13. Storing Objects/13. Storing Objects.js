function solve(args) {
    let objects = [];

    for(let i = 0; i < args.length; i++) {
        let nameAgeGrade = args[i].split(" -> ");

        objects.push ({
            name: nameAgeGrade[0],
            age: nameAgeGrade[1],
            grade: nameAgeGrade[2]
        })
    }

    for(let i = 0; i < objects.length; i++)
    {
        console.log(`Name: ${objects[i].name}`);
        console.log(`Age: ${objects[i].age}`);
        console.log(`Grade: ${objects[i].grade}`);
    }
}

solve(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']);