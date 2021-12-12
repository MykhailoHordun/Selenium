Feature: OrangeTests
	Testing OrangeHRM Pay Grad
	
  Scenario: Add Pay Grad
    #Adding Record 
    Given I am on Pay Grades page
    When I click Add button
    And I enter <name>
    And I click Save button to save Pay Grade name

    And I click Add button in Assigned Currencies
    And I enter  <Currency>, <minSal>, <maxSal>
    And I click Save button to save currency

    And I go to Pay Grades page
    Then I am observing my record with Pay Grade equal to <name> and currency equal to <Currency>
    
    #Deleting Record
    When I click in checkbox on the left of <name>
    And I click Delete button
    And I click Ok button in dialog box
    Then I am observing Pay Grade table without my record

