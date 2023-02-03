// You have a positive number n consisting of digits. You can do at most one operation: Choosing the index of a digit
// in the number, remove this digit at that index and insert it back to another or at the same place in the number in
// order to find the smallest number you can get.
//
// Task:
// Return an array or a tuple or a string depending on the language (see "Sample Tests") with
//
// 1. the smallest number you got
// 2. the index i of the digit d you took, i as small as possible
// 3. the index j (as small as possible) where you insert this digit d to have the smallest number.

function smallest(n) {
    let numberString = n.toString();
    let minNumber = n;
    let indexFrom = 0;
    let indexTo = 0;
    for (let i = 0; i < numberString.length; i++) {
        let removed = numberString.slice(0, i) + numberString.slice(i + 1);
        for (let j = 0; j < removed.length + 1; j++) {
            let numberCheck = parseInt(removed.slice(0, j) + numberString[i] + removed.slice(j));
            if (numberCheck < minNumber) {
                minNumber = numberCheck;
                indexFrom = i;
                indexTo = j;
            }
        }
    }
    return [minNumber, indexFrom, indexTo];
}


console.log(smallest(261235));  // [126235, 2, 0]
console.log(smallest(209917));  // [29917, 0, 1]
console.log(smallest(285365));  // [238565, 3, 1]
console.log(smallest(269045));  // [26945, 3, 0]
console.log(smallest(296837));  // [239687, 4, 1]
console.log(smallest(1000000)); // [1, 0, 6]
