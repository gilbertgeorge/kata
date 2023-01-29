// Implement a pseudo-encryption algorithm which given a string S and an integer N concatenates
// all the odd-indexed characters of S with all the even-indexed characters of S, this process
// should be repeated N times.
//
// Examples:
//
// encrypt("012345", 1)  =>  "135024"
// encrypt("012345", 2)  =>  "135024"  ->  "304152"
// encrypt("012345", 3)  =>  "135024"  ->  "304152"  ->  "012345"
//
// encrypt("01234", 1)  =>  "13024"
// encrypt("01234", 2)  =>  "13024"  ->  "32104"
// encrypt("01234", 3)  =>  "13024"  ->  "32104"  ->  "20314"
// Together with the encryption function, you should also implement a decryption function which reverses the process.
//
// If the string S is an empty value or the integer N is not positive, return the first argument without changes.

function scramble(text) {
    let odd = text.split('').filter((v, i) => i % 2 === 0).join('');
    let even = text.split('').filter((v, i) => i % 2 !== 0).join('');
    return even + odd;
}

function encrypt(text, n) {
    while(n > 0 && text) {
        text = scramble(text);
        n--;
    }
    return text;
}

function unscramble(text) {
    let odd = text.slice(0, text.length / 2).split('');
    let even = text.slice(text.length / 2).split('');
    let result = [];
    for (let i = 0; i < text.length; i++) {
        if (i % 2 === 0) {
            result.push(even.shift());
        } else {
            result.push(odd.shift());
        }
    }
    return result.join('');
}

function decrypt(encryptedText, n) {
    while(n > 0 && encryptedText) {
        encryptedText = unscramble(encryptedText);
        n--;
    }
    return encryptedText;
}

console.log(encrypt("This is a test!", 0));  // "This is a test!"
console.log(encrypt("This is a test!", 1));  // "hsi  etTi sats!"
console.log(encrypt("This is a test!", 2));  // "s eT ashi tist!"
console.log(encrypt("This is a test!", 3));  // " Tah itse sits!"
console.log(encrypt("This is a test!", 4));  // "This is a test!"
console.log(encrypt("This is a test!", -1));  // "This is a test!"
console.log(encrypt("This kata is very interesting!", 1));  // "hskt svr neetn!Ti aai eyitrsig"
console.log()
console.log(decrypt("This is a test!", 0));  // "This is a test!"
console.log(decrypt("hsi  etTi sats!", 1));  // "This is a test!" [8,1,9,2,10,3,11,4,12,5,13,6,14,7]
console.log(decrypt("s eT ashi tist!", 2));  // "This is a test!"
console.log(decrypt(" Tah itse sits!", 3));  // "This is a test!"
console.log(decrypt("This is a test!", 4));  // "This is a test!"
console.log(decrypt("This is a test!", -1)); // "This is a test!"
console.log(decrypt("hskt svr neetn!Ti aai eyitrsig", 1));  // "This kata is very interesting!"

