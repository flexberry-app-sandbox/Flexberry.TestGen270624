import { moduleFor, test } from 'ember-qunit';

moduleFor('route:data-line-test-gen270624-факт-т-о-l', 'Unit | Route | data-line-test-gen270624-факт-т-о-l', {
  // Specify the other units that are required for this test.
  needs: [
    'service:cols-config-menu',
    'service:form-load-time-tracker',
    'service:objectlistview-events',
    'service:app-state',
    'service:adv-limit',
  ],
});

test('it exists', function(assert) {
  let route = this.subject();
  assert.ok(route);
});
