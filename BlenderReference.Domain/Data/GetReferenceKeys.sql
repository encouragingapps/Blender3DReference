Select rk.Id,
	   rk.[Description],
       mt.ModeName,
	   mt.Id as [ModeTypeId],
	   [at].AreaName,
	   [at].Id as [AreaTypeId],
	   rk.CanGrabScaleRotate,
	   rk.CanRestrictToXYZAxis,
	   rk.CanEnterNumericValue,
	   rk.HasScrollWheelFeature,
	   rk.Comment
from ReferenceKey rk
Join ModeType mt on mt.Id = rk.ModeTypeId
Join AreaType [at] on at.Id = rk.AreaTypeId
