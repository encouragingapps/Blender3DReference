Select HotKeyName, OrderId
From ReferenceKeyHotKey r
Join HotKeyType h on h.Id = r.HotKeyTypeId
Where r.ReferenceKeyId = {0}