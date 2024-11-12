import { ModuleWithProviders, NgModule } from '@angular/core';
import { COURCE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class CourceConfigModule {
  static forRoot(): ModuleWithProviders<CourceConfigModule> {
    return {
      ngModule: CourceConfigModule,
      providers: [COURCE_ROUTE_PROVIDERS],
    };
  }
}
