function solve(args) {
    let dict = [];

    for(let i = 0; i < args.length - 1; i++) {
        let kvp = args[i].split(' ');

        dict.push ({
            key: kvp[0],
            value: kvp[1]
        })
    }

    let found = false;
    for(let key of dict)
    {
        if(key.key === args[args.length - 1]) {
            found = true;
            break;
        }
    }

    if (found) {
        for (let i = 0; i < dict.length; i++)
        {
            if (dict[i].key === args[args.length - 1]){
                console.log(dict[i].value)
            }
        }
    } else {
        console.log("None");
    }
}

solve(['key value', 'key niggers', 'test jews', 'key']);