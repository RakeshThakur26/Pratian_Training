import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemAllocationComponent } from './system-allocation.component';

describe('SystemAllocationComponent', () => {
  let component: SystemAllocationComponent;
  let fixture: ComponentFixture<SystemAllocationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SystemAllocationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemAllocationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
