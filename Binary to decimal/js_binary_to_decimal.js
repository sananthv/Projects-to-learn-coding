// Project to learn coding
// By Ananth Selladoray

var num = prompt();

var binary = [];

while (num !==1){
	binary.unshift(num%2);
	num = (num - (num % 2)) / 2;
}

binary.unshift(1);

binary.join("");

console.log(binary);