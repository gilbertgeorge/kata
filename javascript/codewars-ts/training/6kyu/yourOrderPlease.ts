// Your task is to sort a given string. Each word in the string will contain a single number.
// This number is the position the word should have in the result.
//
// Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
//
// If the input string is empty, return an empty string. The words in the input String will
// only contain valid consecutive numbers.


export function order(words:string): string {
    type OrderedWord = {
        word: string;
        order: number;
    };
    let result = "";
    if (words.length > 0) {
        const wordsArray = words.split(" ");
        const orderedWords = wordsArray.map(word => {
            let order = 0
            let match = word.match(/\d+/);
            if (match) {
                order = parseInt(match[0]);
            }
            return {word, order} as OrderedWord;
        });
        const sortedOrderedWords = orderedWords
            .sort((a: OrderedWord, b: OrderedWord) => a.order - b.order);
        const sortedWordsArray = sortedOrderedWords.map(orderedWord => orderedWord.word);
        result = sortedWordsArray.join(" ");
    }
    return result;
}

import {assert} from "chai";

describe("solution", function(){
    it("basicTests", function(){
        assert.equal(order("is2 Thi1s T4est 3a"), "Thi1s is2 3a T4est");
        assert.equal(order("4of Fo1r pe6ople g3ood th5e the2"), "Fo1r the2 g3ood 4of th5e pe6ople");
        assert.equal(order(""), "");
    });
});