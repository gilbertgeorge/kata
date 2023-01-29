// Count the number of Duplicates
// Write a function that will return the count of distinct case-insensitive alphabetic characters
// and numeric digits that occur more than once in the input string. The input string can be assumed
// to contain only alphabets (both uppercase and lowercase) and numeric digits.
//
// Example
// "abcde" -> 0 # no characters repeats more than once
// "aabbcde" -> 2 # 'a' and 'b'
// "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
// "indivisibility" -> 1 # 'i' occurs six times
// "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
// "aA11" -> 2 # 'a' and '1'
// "ABBA" -> 2 # 'A' and 'B' each occur twice


function duplicateCountBetter(text){
    return text.toLowerCase().split('').filter(function(val, i, arr){
        return arr.indexOf(val) !== i && arr.lastIndexOf(val) === i;
    }).length;
}


function duplicateCount(text) {
    let countJson = {};
    for (let i = 0; i < text.length; i++) {
        let char = text[i].toLowerCase();
        if (countJson[char]) {
            countJson[char]++;
        } else {
            countJson[char] = 1;
        }
    }

    let duplicates = 0;
    for (let key in countJson) {
        if (countJson[key] > 1) {
            duplicates++;
        }
    }
    return duplicates;
}

console.log(duplicateCount(''));  // 0
console.log(duplicateCount('abcde'));  // 0
console.log(duplicateCount('aabbcde'));  // 2
console.log(duplicateCount('aabBcde'));  // 2
console.log(duplicateCount('indivisibility'));  // 1
console.log(duplicateCount('Indivisibilities'));  // 2
console.log(duplicateCount('aA11'));  // 2
console.log(duplicateCount('ABBA'));  // 2
