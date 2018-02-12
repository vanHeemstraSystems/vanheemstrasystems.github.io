// calculator.test.js

test('calls calculator to equal "Hello World!"', () => {
    const calculator = require('./calculator');
    expect(calculator()).toBe('Hello World!');
});