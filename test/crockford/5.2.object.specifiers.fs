module {

// 5.2 Object Specifiers
document.write("<div><strong>5.2 Object Specifiers</strong></div>");

static class maker {
    var first, last, state, city;
}

var myObject = maker({
    first: "1981-04-26",
    last: "2010-04-26",
    state: "Utrecht",
    city: "Utrecht"
});

assert(myObject.first === "1981-04-26", "myObject has correct first");
assert(myObject.last === "2010-04-26", "myObject has correct last");
assert(myObject.state === "Utrecht", "myObject has correct state");
assert(myObject.city === "Utrecht", "myObject has correct city");

}
