//==========================================================================//
// Copyright Elhoussine Mehnik (ue4resources@gmail.com). All Rights Reserved.
//================== http://unrealengineresources.com/ =====================//

#pragma once

#include "CoreMinimal.h"
#include "Input/Reply.h"
#include "IDetailCustomization.h"

class IDetailLayoutBuilder;
class UProceduralTreeComponent;

class FTreeMeshComponentDetails : public IDetailCustomization
{
public:
	/** Makes a new instance of this detail layout class for a specific detail view requesting it */
	static TSharedRef<IDetailCustomization> MakeInstance();

	/** IDetailCustomization interface */
	virtual void CustomizeDetails( IDetailLayoutBuilder& DetailBuilder ) override;

	/** Handle clicking the convert button */
	FReply ClickedOnConvertToStaticMesh();

	/** Is the convert button enabled */
	bool ConvertToStaticMeshEnabled() const;

	/** Util to get the TreeMeshComp we want to convert */
	UProceduralTreeComponent* GetFirstSelectedTreeMeshComp() const;

	/** Cached array of selected objects */
	TArray< TWeakObjectPtr<UObject> > SelectedObjectsList;
};
