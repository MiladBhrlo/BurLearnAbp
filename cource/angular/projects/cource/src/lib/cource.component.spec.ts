import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { CourceComponent } from './components/cource.component';
import { CourceService } from '@cource';
import { of } from 'rxjs';

describe('CourceComponent', () => {
  let component: CourceComponent;
  let fixture: ComponentFixture<CourceComponent>;
  const mockCourceService = jasmine.createSpyObj('CourceService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [CourceComponent],
      providers: [
        {
          provide: CourceService,
          useValue: mockCourceService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CourceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
