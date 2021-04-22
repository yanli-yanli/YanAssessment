describe('First Test - open tab', () => {
    it('Vist commbank main page', () => {

        //go to commbank mainpage
        cy.visit('https://www.commbank.com.au/')

        //click first tab banking
        cy.get('a[href*="https://www.commbank.com.au/banking.html?ei=mv_banking"]')
        .contains('Banking').click()
        //test if title is load successfully
        cy.title().should('eq', 'Banking - CommBank'); // Test fully load page Banking tab title
        
        //click second tab Home LOan
        cy.get('a[href*="https://www.commbank.com.au/home-loans.html?ei=mv_home-loans"]')
        .contains('Home loans').click()

        //test if title is load successfully
        cy.title().should('eq', 'Home loans - calculators, guides and compare - CommBank'); // Test fully load page home loan tab title


        //click third tab Insurance
        cy.get('a[href*="https://www.commbank.com.au/insurance.html?ei=mv_insurance"]')
        .contains('Insurance').click()

        //test if title is load successfully
        cy.title().should('eq', 'Insurance - CommBank'); // Test fully load page insurance tab title


        //click third tab Insurance
        cy.get('a[href*="https://www.commbank.com.au/investing-and-super.html?ei=mv_investing-super"]')
        .contains('Investing & super').click()

        //test if title is load successfully
        cy.title().should('eq', 'Investing & Super - CommBank'); // Test fully load page insurance tab title

        //click fifth tab Insurance
        cy.get('a[href*="https://www.commbank.com.au/business.html?ei=mv_business"]')
        .contains('Business').click()

        //test if title is load successfully
        cy.title().should('eq', 'Business Banking - CommBank'); // Test fully load page insurance tab title

        //click fifth tab Insurance
        cy.get('a[href*="https://www.commbank.com.au/institutional.html?ei=mv_institutional"]')
        .contains('Institutional').click()

        //test if title is load successfully
        cy.title().should('eq', 'Institutional - CommBank'); // Test fully load page insurance tab title





    })
  })