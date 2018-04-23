#Application TestConditionalAppearanceRulesWin
#Application TestConditionalAppearanceRulesWeb

*Action New(Person)

*FillForm
 Name = Jane Smith
 Is Married = true
 
*FillForm
 Spouse Name = John Smith

*FillForm
 Is Married = false
 
!FillForm
 Spouse Name = John Smith
 


 
