import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CourceComponent } from './components/cource.component';
import { CourceRoutingModule } from './cource-routing.module';

@NgModule({
  declarations: [CourceComponent],
  imports: [CoreModule, ThemeSharedModule, CourceRoutingModule],
  exports: [CourceComponent],
})
export class CourceModule {
  static forChild(): ModuleWithProviders<CourceModule> {
    return {
      ngModule: CourceModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<CourceModule> {
    return new LazyModuleFactory(CourceModule.forChild());
  }
}
