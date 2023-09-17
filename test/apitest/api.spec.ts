import {test, expect} from "@playwright/test";

test.describe.parallel("API testing", ()=> {
    const baseUrl = 'http://localhost:8080'
    test("Test for the example endpoint", async ({request}) =>{
        const response = await request.get(`${baseUrl}/example`)
        expect(response.status()).toBe(200)
        const responseBody = JSON.parse(await response.text())
        expect(responseBody.message).toBe('Привет, Максим!')
    })
})