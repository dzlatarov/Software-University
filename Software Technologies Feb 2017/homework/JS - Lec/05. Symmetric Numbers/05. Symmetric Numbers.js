function solve(args){
    let num = Number(args[0]);

    for (let i = 1; i <= num; i++) {
        if (isSym(i)) {
            console.log(i);
        }
    }

    function isSym(number) {
        number = number.toString();

        let length = number.length;
        for (let i = 0; i < length / 2; i++) {
            if (number[i] !== number[length - i - 1]) {
                return false;
            }
        }

        return true;
    }
}

solve (['750']);