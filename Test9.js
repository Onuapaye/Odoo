//This project is basically implement using the ASCII codes of the alphabets
/*
	The ASCII codes of the alphabets starts from 65 or 065 to 90 or 090 for uppercase characters as shown
	Letter	 ASCII
	A	     065
	B	     066
	C	     067
	D	     068
	E	     069
	F	     070
	G	     071
	H	     072
	I	     073
	J	     074
	K	     075
	L	     076
	M	     077
	N	     078
	O	     079
	P	     080
	Q	     081
	R	     082
	S	     083
	T	     084
	U	     085
	V	     086
	W	     087
	X	     088
	Y	     089
	Z	     090
*/

function handleArrayOfAlphabets() {

    const alphabetsArray = []

    const lowerBoundASCII = 65; // A ...
    const upperBoundASCII = 90; // Z

    for (let i = lowerBoundASCII; i <= upperBoundASCII; i++) {
        alphabetsArray.push(String.fromCharCode(i));
    }

    return alphabetsArray;
}

let res = handleArrayOfAlphabets();

console.log('This is the results\n' + res);