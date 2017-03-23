function solve(args) {
    let dict = [];

    for(let i = 0; i < args.length - 1; i++) {
        let kvp = args[i].split(' ');

        dict[kvp[0]] = kvp[1];
    }

    if(dict[args[args.length - 1]] != undefined) {
        console.log(dict[args[args.length - 1]]);
    } else {
        console.log("None");
    }
}

solve(['key value', 'key niggers', 'test jews', 'key']);
