function solve(args) {
    args.map(Number);
    let counter = 0;

    for(let i = 0; i < args.length; i++) {
        if (args[i] < 0) {
            counter++;
        }
    }

    if(counter % 2 == 0) {
        return "Positive";
    } else {
        return "Negative";
    }
}

solve(['2', '3', '-1']);