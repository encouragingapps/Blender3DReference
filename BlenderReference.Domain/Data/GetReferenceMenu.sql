Select 	m.Id, 
		m.MenuDescription, 
		m.MenuNavigation, 
		m.Comments, 
		m.ImagePath, 
		t.Id as [ModeTypeId], 
		t.ModeName
From Menu m
Join ModeType t on t.Id = m.ModeTypeId