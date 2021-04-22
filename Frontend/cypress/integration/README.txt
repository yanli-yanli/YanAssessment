How to run the test:

1.Open Cypress - 
2.In Test runner window, frontEndTestA.js will be shown.
3.Run the test by Chrome or Firefox.
4.Change ViewPort configuration from cypress.json and run the test again.


Test Note:
1. The commBank main page contains application jQuery error which affects our test.
   We can turn off this error catching in index.js as a workaround.

2. By default, Cypress will wait for the web page to load all resources before continuing the test.
   Our test checks whether the page is fully loaded by chekcing if the title of the tab is loaded correctly.
