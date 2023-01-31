// You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too
// early to an appointment, so you decided to take the opportunity to go for a short walk. The city provides
// its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an
// array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only
// a single block for each letter (direction) and you know it takes you one minute to traverse one city block,
// so create a function that will return true if the walk the app gives you will take you exactly ten minutes
// (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.
//
// Note: you will always receive a valid array containing a random assortment of direction letters
// ('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).

export function isValidWalk(walk: string[]) {
    if (walk.length !== 10) {
        return false;
    }
    let coordinates = [0, 0];
    for (let direction of walk) {
        switch (direction) {
            case 'n':
                coordinates[1]++;
                break;
            case 's':
                coordinates[1]--;
                break;
            case 'e':
                coordinates[0]++;
                break;
            case 'w':
                coordinates[0]--;
                break;
        }
    }
    return (coordinates[0] === 0 && coordinates[1] === 0);
}

import { assert } from "chai";


describe("example", function() {
    it("test", function() {
        assert.equal(isValidWalk(['n','s','n','s','n','s','n','s','n','s']), true);
        assert.equal(isValidWalk(['w','e','w','e','w','e','w','e','w','e','w','e']), false);
        assert.equal(isValidWalk(['w']), false);
        assert.equal(isValidWalk(['n','n','n','s','n','s','n','s','n','s']), false);
    });
});