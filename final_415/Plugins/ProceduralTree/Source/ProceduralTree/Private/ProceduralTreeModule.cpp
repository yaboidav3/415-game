//==========================================================================//
// Copyright Elhoussine Mehnik (ue4resources@gmail.com). All Rights Reserved.
//================== http://unrealengineresources.com/ =====================//

#include "ProceduralTreeModule.h"


class FProceduralTreeModule : public IProceduralTreeModule
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE( FProceduralTreeModule, ProceduralTree)



void FProceduralTreeModule::StartupModule()
{
	
}


void FProceduralTreeModule::ShutdownModule()
{
	
}



