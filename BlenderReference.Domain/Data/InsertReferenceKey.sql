Insert into ReferenceKey ([Description],
                          [ModeTypeId],
                          [AreaTypeId],
                          [CanGrabScaleRotate],
                          [CanRestrictToXYZAxis],
                          [CanEnterNumericValue],
                          [HasScrollWheelFeature],
                          Comment) 
                          Values 
                          (@Description, 
                           @ModeTypeId, 
                           @AreaTypeId, 
                           @CanGrabScaleRotate,
                           @CanRestrictToXYZAxis,
                           @CanEnterNumericValue,
                           @HasScrollWheelFeature,
                           @Comment);

Select last_insert_rowid();