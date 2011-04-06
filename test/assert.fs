var succeeded = "<span style=\"color: green;\">SUCCEEDED</span>";
var failed = "<span style=\"color: red;\">FAILED</span>";

function assert(assertion, message) {
  document.write("<div>" + message + ": " + (assertion ? succeeded : failed) + "</div>");
}
