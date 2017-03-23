function solve(args) {
    let count = Number(args[0]);
    let array = [];

    for(let i = 0; i < count; i++)
    {
        array[i] = 0;
    }

    for (let i = 1; i < args.length; i++) {
        let indexNumber = args[i].split(" - ");

        array[Number(indexNumber[0])] = indexNumber[1];
    }

    for(let i = 0; i < array.length; i++) {
        console.log(array[i]);
    }
}

solve(['2', '0 - 5', '0 - 6', '0 - 7']);
