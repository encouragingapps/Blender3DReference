Select a.Id,
       a.WalkthroughName,
	   b.WalkthroughScenarioId,
	   b.Step,
	   b.StepDescription
From WalkthroughScenario a
Join WalkthroughSteps b on b.WalkthroughScenarioId = a.Id
Where a.Id = {0}